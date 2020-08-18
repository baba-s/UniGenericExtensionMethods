using System;
using System.Collections.Generic;

namespace Kogane
{
	/// <summary>
	/// ジェネリックの拡張メソッドを管理するクラス
	/// </summary>
	public static class GenericExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		public static bool EqualsAny<T>( this T self, IEnumerable<T> values )
		{
			foreach ( var n in values )
			{
				if ( self.Equals( n ) )
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		public static bool EqualsAny<T>( this T self, IReadOnlyList<T> values )
		{
			for ( var i = 0; i < values.Count; i++ )
			{
				var n = values[ i ];
				if ( self.Equals( n ) )
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		public static bool EqualsAny<T>( this T self, params T[] values )
		{
			for ( var i = 0; i < values.Length; i++ )
			{
				var n = values[ i ];
				if ( self.Equals( n ) )
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		[Obsolete( "代わりに EqualsAny を使用してください" )]
		public static bool ContainsAny<T>( this T self, IEnumerable<T> values )
		{
			return self.EqualsAny( values );
		}

		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		[Obsolete( "代わりに EqualsAny を使用してください" )]
		public static bool ContainsAny<T>( this T self, IReadOnlyList<T> values )
		{
			return self.EqualsAny( values );
		}

		/// <summary>
		/// 指定したオブジェクトが 1 つでもこのコレクションに含まれる場合 true を返します
		/// </summary>
		[Obsolete( "代わりに EqualsAny を使用してください" )]
		public static bool ContainsAny<T>( this T self, params T[] values )
		{
			return self.EqualsAny( values );
		}
	}
}