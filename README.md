# Use C# to do UnitTest(MSTest、XUnit)
透過單元測試供使用者快速確認更新後的程式是否有問題，以下為幾個基本的語法:
- `Assert.AreEqual`
- `Assert.AreNotEqual`
- `Assert.AreSame`
- `Assert.AreNotSame`
- `Assert.IsTrue`
- `Assert.IsFalse`
- `Assert.IsInstanceOfType`
- `Assert.IsNotInstanceOfType`
- `Assert.IsNull`
- `Assert.IsNotNull`

基本上C#中的單元測試語法大同小異，例如**是否相等**: 

MSTest: `Assert.AreEqual`

XUnit: `Assert.Equal`

單元測試的區隔方式:

**Arrange** 初始化

**Act** 執行方法、行為、操作並獲取結果

**Assert** 驗證