using System.Runtime.CompilerServices;
using UnityEngine;

namespace ModularStateMachine
{
    public static class StringExtensions
    {
        /// <summary>
        /// computes the FNV-1a hash for the input string.
        /// The FNV-1a hash is a non-cryptographic hash function that is fast and produces a good distribution of hash values.
        /// Useful for creating Dictionary keys instead of using strings directly.
        /// https://youtu.be/HNGJ8KOqdYQ?t=125
        /// </summary>
        public static int ComputeDNV1aHash(this string str)
        { 
            uint hash = 2166136261;
            foreach(char c in str)
            {
                hash ^= c;
                hash *= 16777619;
            }
            return unchecked((int)hash);
        }
    }
}