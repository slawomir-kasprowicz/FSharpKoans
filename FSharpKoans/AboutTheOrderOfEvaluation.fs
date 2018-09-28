namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// About the Order of Evaluation
//
// Sometimes you'll need to be explicit about the order in which
// functions are evaluated. F# offers a couple mechanisms for
// doing this.
//---------------------------------------------------------------
[<Koan(Sort = 4)>]
module ``about the order of evaluation`` =

    [<Koan>]
    let SometimesYouNeedParenthesisToGroupThings() =
        let add x y =
            x + y

        let result = add (add 5 (add 1 1)) 7

        AssertEquality result 14

        (* TRY IT: What happens if you remove the parenthesis?*)

    [<Koan>]
    let TheBackwardPipeOperatorCanAlsoHelpWithGrouping() =
        let add x y =
            x + y

        let double x =
            x * 2

        let result = double <| add 5 8

        AssertEquality result 26
