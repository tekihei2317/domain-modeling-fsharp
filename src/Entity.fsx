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
printfn "%b" (contact1.ContactId = contact2.ContactId)
