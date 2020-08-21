# UniGenericExtensionMethods

ジェネリック型の拡張メソッド

## EqualsAny

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var num  = 1;
        var list = new[] { 1, 2, 3 };

        // 引数に指定した配列やリストに自分自身が含まれている場合 true を取得します
        Debug.Log( num.EqualsAny( list ) );    // True
        Debug.Log( num.EqualsAny( 2, 3, 4 ) ); // False
    }
}
```
