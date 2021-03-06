﻿// FFXIVAPP.Plugin.Parse
// MagicBarrierHelper.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution. 
//  * Neither the name of SyndicatedLife nor the names of its contributors may 
//    be used to endorse or promote products derived from this software 
//    without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE. 

using System.Collections.Generic;

namespace FFXIVAPP.Plugin.Parse.Helpers
{
    public static class MagicBarrierHelper
    {
        private static List<string> _stoneSkin;
        private static List<string> _succor;
        private static List<string> _adloquium;

        public static List<string> StoneSkin
        {
            get
            {
                if (_stoneSkin != null)
                {
                    return _stoneSkin;
                }
                _stoneSkin = new List<string>
                {
                    "stoneskin",
                    "steinhaut",
                    "cuirasse",
                    "ストンスキン"
                };
                return _stoneSkin;
            }
        }

        public static List<string> Succor
        {
            get
            {
                if (_succor != null)
                {
                    return _succor;
                }
                _succor = new List<string>
                {
                    "succor",
                    "kurieren",
                    "traité du soulagement",
                    "士気高揚の策"
                };
                return _succor;
            }
        }

        public static List<string> Adloquium
        {
            get
            {
                if (_adloquium != null)
                {
                    return _adloquium;
                }
                _adloquium = new List<string>
                {
                    "adloquium",
                    "traité du réconfort",
                    "鼓舞激励の策"
                };
                return _adloquium;
            }
        }
    }
}
