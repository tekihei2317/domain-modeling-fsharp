type CustomerId = CustomerId of int
let customerId = CustomerId 42

// decomposition
let (CustomerId innerValue) = customerId
printfn "%d" innerValue

type Undefined = exn
type CustomerInfo = Undefned
type ShippingAddress = Undefned
type BillingAddress = Undefned
type OrderLines = Undefned
type AmountToBill = Undefined

// record type
type Order =
    { CustomerInfo: CustomerInfo
      ShippingAddress: ShippingAddress
      BillingAddress: BillingAddress
      OrderLines: OrderLines
      AmountToBill: AmountToBill }

type UnitQuantity = int
type KilogramQuantity = int

type OrderQuantity =
    | Unit of UnitQuantity
    | Kilogram of KilogramQuantity

// Workflow
type UnvalidatedOrder = Undefined
type ValidatedOrder = Undefined

type ValidationError =
    { FieldName: string
      ErrorDescription: string }

type ValidationResponse<'a> = Async<Result<'a, ValidationError list>>
type ValidateOrder = UnvalidatedOrder -> ValidationResponse<ValidatedOrder>
