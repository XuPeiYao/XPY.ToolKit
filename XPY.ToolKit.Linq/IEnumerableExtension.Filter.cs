﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XPY.ToolKit.Linq {
    public static partial class IEnumerableExtension {
        /// <summary>
        /// 針對指定屬性取得值相等的成員
        /// </summary>
        /// <typeparam name="TSource">列舉元素類型</typeparam>
        /// <typeparam name="TProperty">條件屬性類型</typeparam>
        /// <param name="source">列舉來源</param>
        /// <param name="selector">查詢屬性</param>
        /// <param name="value">值，如為空則表示不篩選</param>
        /// <returns>查詢結果</returns>
        public static IEnumerable<TSource> Filter<TSource, TProperty>(
            this IEnumerable<TSource> source,
            Func<TSource, TProperty> selector,
            Nullable<TProperty> value) where TProperty : struct {
            var result = source;

            if (value == null) return result;

            return result.Where(x => {
                var v = selector(x);

                return value.Equals(v);
            });
        }
    }
}
