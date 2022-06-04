type ContactId = ContactId of int
type PhoneNumber = string
type EmailAddress = string

[<NoEquality; NoComparison>]
type Contact =
    { ContactId: ContactId
      PhoneNumber: PhoneNumber
      EmailAddress: EmailAddress }

let contactId = ContactId 1

let contact1: Contact =
    { ContactId = contactId
      PhoneNumber = PhoneNumber "123-456-7890"
      EmailAddress = EmailAddress "test@example.com" }

let contact2: Contact =
    { ContactId = contactId
      PhoneNumber = PhoneNumber "123-456-7890"
      EmailAddress = EmailAddress "test@example.com" }

// NoEqualityをつけたのでエラーになる
// printfn "%b" (contact1 = contact2)

// IDを直接比較する
printfn "contact: %b" (contact1.ContactId = contact2.ContactId)

type OrderId = OrderId of string
type ProductId = ProductId of string

// 複数のプロパティで比較する場合は、新しくプロパティを定義すると楽
[<NoEquality; NoComparison>]
type OrderLine =
    { OrderId: OrderId
      ProductId: ProductId
      Qty: int }
    member this.Key = (this.OrderId, this.ProductId)

let line1: OrderLine =
    { OrderId = OrderId "1"
      ProductId = ProductId "1"
      Qty = 10 }

let line2: OrderLine =
    { OrderId = OrderId "1"
      ProductId = ProductId "1"
      Qty = 20 }

printfn "order line: %b" (line1.Key = line2.Key)
