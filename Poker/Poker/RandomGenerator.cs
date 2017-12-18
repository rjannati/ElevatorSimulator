using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Poker
{
    internal class RandomByteGenerator
    {
		private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

		public byte[] Generate(byte[] bytes)
		{
			rng.GetBytes(bytes);
			return bytes;
		}
    }
}
