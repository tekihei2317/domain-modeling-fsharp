// choice type
type WidgetCode = string
type GizmoCode = string

type ProductCode =
    | Widget of WidgetCode
    | Gizmo of GizmoCode

// Value Objectを比較する
let widgetCode1 = WidgetCode "W1234"
let widgetCode2 = WidgetCode "W1234"
printfn "code1 = code2: %b" (widgetCode1 = widgetCode2)

type User = { FirstName: string; LastName: string }

let name1 =
    { FirstName = "Alex"
      LastName = "Adams" }

let name2 =
    { FirstName = "Alex"
      LastName = "Adams" }

printfn "name1 = name2: %b" (name1 = name2)

// レコード型や選択型は、値が同じであれば比較したときにtrueになる
// →Value Objectとして扱える
