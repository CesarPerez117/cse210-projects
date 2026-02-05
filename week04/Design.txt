Design for YoutubeVideo Program

Program
   └── Main()

Video
   ├── _title
   ├── _author
   ├── _length
   ├── _commentsList (List<Comment>)
   ├── _videoList (List<Video>)
   └── Methods: GetTitle, SetTitle, GetAuthor, SetAuthor, GetLength, SetLength, //Getters and Setters
                AddCommentToList, DisplayVideoInfo, GetNumberOfComments

Comment
   ├── _name
   ├── _text
   └── Methods: DisplayCommentInfo


Responsibilities

* Program
    - Displays an intro message. 
    - Creates several Video objects. 
    - Sets each video’s title, author, length.
    - Adds comments to each video. 
    - Stores all videos inside a videoManager object. 
    - Iterates through the list of videos and calls DisplayVideoInfo() to show details.

* Video
    - Store video metadata. 
    - Add comments (AddCommentToList()).
    - Display video info (DisplayVideoInfo()), including:
        - Title, author, length.
        - Number of comments.
        - Each comment’s info.

* Comments
    - Store comment data.
    - Display comment info (DisplayCommentInfo()).


Design for OnlineOrdering Program

Program
 └── Main(args: string[]): void
     ├── Creates Address objects
     ├── Creates Customer objects (linked to Address)
     ├── Creates Product objects
     ├── Creates Order objects (linked to Customer + Products)
     └── Displays PackingLabel(), ShippingLabel(), CalculateTotalCost()

Order
 ├── Attributes:
 │    - _products: List<Product>
 │    - _customer: Customer
 │    - _totalCost: double
 │    - _shippingFee: double
 ├── Methods:
 │    + Order(products: List<Product>, customer: Customer)
 │    + CalculateTotalCost(): double
 │    + PackingLabel(): string
 │    + ShippingLabel(): string
 └── Relationships:
      • Contains Products
      • Linked to Customer

Product
 ├── Attributes:
 │    - _productName: string
 │    - _productID: int
 │    - _productPrice: double
 │    - _quantity: int
 ├── Methods:
 │    + Product(name: string, id: int, price: double, qty: int)
 │    + CalculatePrice(): double
 │    + GetProductName(): string
 │    + GetProductID(): int
 │    + GetProductPrice(): double
 │    + GetQuantity(): int
 └── Relationships:
      • Used inside Order

Customer
 ├── Attributes:
 │    - _customerName: string
 │    - _address: Address
 ├── Methods:
 │    + Customer(name: string, address: Address)
 │    + GetCustomerName(): string
 │    + GetCustomerAddress(): Address
 │    + IsInUSA(): bool
 └── Relationships:
      • Linked to Address
      • Associated with Orders

Address
 ├── Attributes:
 │    - _street: string
 │    - _city: string
 │    - _state: string
 │    - _country: string
 ├── Methods:
 │    + Address(street: string, city: string, state: string, country: string)
 │    + IsInUSA(): bool
 │    + GetAddress(): string
 └── Relationships:
      • Used by Customer└── Determines if country is USA


 Relationships Summary
- Program → Order: Program creates and manages orders.
- Order → Product: Each order contains multiple products.
- Order → Customer: Each order is linked to a customer.
- Customer → Address: Each customer has an address.