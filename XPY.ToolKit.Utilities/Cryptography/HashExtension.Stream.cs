﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XPY.ToolKit.Utilities.Cryptography {
    public static partial class HashExtension {
        /// <summary>
        /// 將串流使用指定的雜湊演算法轉換為雜湊
        /// </summary>
        /// <typeparam name="Algorithm">雜湊演算法型別</typeparam>
        /// <param name="stream">串流實例</param>
        /// <returns>雜湊Binary</returns>
        public static byte[] ToHash<Algorithm>(this Stream stream) where Algorithm : HashAlgorithm {
            return HashUtility.ToHash<Algorithm>(stream);
        }

        /// <summary>
        /// 將串流使用指定的雜湊演算法轉換為雜湊後在轉換為16進位字串表示
        /// </summary>
        /// <typeparam name="Algorithm">雜湊演算法型別</typeparam>
        /// <param name="stream">串流實例</param>
        /// <param name="upper">是否轉換為大寫</param>
        /// <returns>雜湊字串</returns>
        public static string ToHashString<Algorithm>(this Stream stream, bool upper = true) where Algorithm : HashAlgorithm {
            return HashUtility.ToHashString<Algorithm>(stream, upper);
        }
    }
}
