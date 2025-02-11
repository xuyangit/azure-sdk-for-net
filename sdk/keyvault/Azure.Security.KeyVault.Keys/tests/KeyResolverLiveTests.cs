﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Cryptography;
using Azure.Core.Testing;
using Azure.Identity;
using Azure.Security.KeyVault.Keys.Cryptography;
using Azure.Security.KeyVault.Secrets;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Azure.Security.KeyVault.Keys.Tests
{
    public class KeyResolverLiveTests : KeysTestBase
    {
        public KeyResolverLiveTests(bool isAsync) : base(isAsync)
        {
        }

        public KeyResolver Resolver { get { return GetResolver(); } }

        public KeyResolver GetResolver(TestRecording recording = null)
        {
            recording ??= Recording;

            return InstrumentClient(new KeyResolver(recording.GetCredential(new DefaultAzureCredential()), recording.InstrumentClientOptions(new CryptographyClientOptions())));
        }

        public SecretClient GetSecretClient(TestRecording recording = null)
        {
            recording ??= Recording;

            return InstrumentClient(new SecretClient(VaultUri, recording.GetCredential(new DefaultAzureCredential()), recording.InstrumentClientOptions(new SecretClientOptions())));
        }

        [Test]
        public void ResolveNonExistantKeyId()
        {
            var uriBuilder = new RequestUriBuilder();

            uriBuilder.Reset(VaultUri);

            uriBuilder.AppendPath($"/keys/");

            uriBuilder.AppendPath(Recording.GenerateId());

            Assert.ThrowsAsync<RequestFailedException>(() => Resolver.ResolveAsync(uriBuilder.ToUri()));
        }

        [Test]
        public void ResolveNonExistantSecretId()
        {
            var uriBuilder = new RequestUriBuilder();

            uriBuilder.Reset(VaultUri);

            uriBuilder.AppendPath($"/secrets/");

            uriBuilder.AppendPath(Recording.GenerateId());

            Assert.ThrowsAsync<RequestFailedException>(() => Resolver.ResolveAsync(uriBuilder.ToUri()));
        }

        [Test]
        public async Task ResolveKeyId()
        {
            string keyName = Recording.GenerateId();

            Key key = await Client.CreateKeyAsync(keyName, KeyType.Rsa);

            RegisterForCleanup(keyName);

            CryptographyClient cryptoClient = await Resolver.ResolveAsync(key.Id);

            cryptoClient = InstrumentClient(cryptoClient);

            Assert.IsNotNull(cryptoClient);

            byte[] toWrap = new byte[32];

            Recording.Random.NextBytes(toWrap);

            WrapResult wrapResult = await cryptoClient.WrapKeyAsync(KeyWrapAlgorithm.RsaOaep, toWrap);

            UnwrapResult unwrapResult = await cryptoClient.UnwrapKeyAsync(KeyWrapAlgorithm.RsaOaep, wrapResult.EncryptedKey);

            CollectionAssert.AreEqual(toWrap, unwrapResult.Key);
        }

        [Test]
        public async Task ResolveSecretId()
        {
            SecretClient secretClient = GetSecretClient();

            // using Random to create a key so it is consistent for the recording. IRL this would be
            // a major security no no.  We would need to use AES.Create or RNGCryptoServiceProvider
            byte[] key = new byte[32];

            Recording.Random.NextBytes(key);

            Secret secret = new Secret(Recording.GenerateId(), Base64Url.Encode(key))
            {
                Properties =
                {
                    ContentType = "application/octet-stream"
                }
            };

            secret = await secretClient.SetSecretAsync(secret);

            CryptographyClient cryptoClient = await Resolver.ResolveAsync(secret.Id);

            cryptoClient = InstrumentClient(cryptoClient);

            Assert.IsNotNull(cryptoClient);

            byte[] toWrap = new byte[32];

            Recording.Random.NextBytes(toWrap);

            WrapResult wrapResult = await cryptoClient.WrapKeyAsync(KeyWrapAlgorithm.A256KW, toWrap);

            UnwrapResult unwrapResult = await cryptoClient.UnwrapKeyAsync(KeyWrapAlgorithm.A256KW, wrapResult.EncryptedKey);

            CollectionAssert.AreEqual(toWrap, unwrapResult.Key);
        }

        [Test]
        public async Task ResolveAsInterface()
        {
            string keyName = Recording.GenerateId();

            Key key = await Client.CreateKeyAsync(keyName, KeyType.Rsa);

            RegisterForCleanup(keyName);

            IKeyEncryptionKey kek = await ((IKeyEncryptionKeyResolver)Resolver).ResolveAsync(key.Id.ToString());

            Assert.IsNotNull(kek);
        }
    }
}
