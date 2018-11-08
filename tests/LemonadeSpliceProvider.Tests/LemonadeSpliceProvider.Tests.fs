module LemonadeSpliceProviderTests


open MyNamespace
open NUnit.Framework

type Generative2 = LemonadeSpliceProvider.GenerativeProvider<2>

[<Test>]
let ``Can access properties of generative provider 2`` () =
    let obj = Generative2()
    let actual = obj.SpliceMethod() |> Async.RunSynchronously
    Assert.AreEqual("12", actual)

