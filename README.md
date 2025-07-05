# 🛒 E-Commerce System

A robust and feature-rich e-commerce system built with C# and .NET 9.0, designed to handle product management, shopping cart operations, checkout processes, and shipping calculations.

## ✨ Features

### 🛍️ **Core E-Commerce Features**
- **Product Management**: Support for both expirable and non-expirable products
- **Shopping Cart**: Add items with quantity validation and stock checking
- **Checkout System**: Complete checkout process with balance validation
- **Shipping Calculator**: Weight-based shipping fee calculation
- **Receipt Generation**: Professional formatted receipts with itemized billing

### 🏗️ **Architecture**
- **Clean Architecture**: Separation of concerns with Entities, Models, and Services
- **Object-Oriented Design**: Proper inheritance and interface implementation
- **Error Handling**: Comprehensive exception handling for business logic
- **Input Validation**: Robust validation for all user inputs

## 🚀 Quick Start

### Prerequisites
- .NET 9.0 SDK
- Visual Studio 2022 or VS Code

### Installation & Running
```bash
# Clone the repository
git clone <https://github.com/omar-28-2/ECommerceSystem.git>
cd ECommerceSystem

# Build the project
dotnet build

# Run the application
dotnet run
```

## 📁 Project Structure

```
ECommerceSystem/
├── Entities/
│   └── Customer.cs          # Customer entity with balance management
├── Models/
│   ├── Product.cs           # Abstract base product class
│   ├── ExpiredProduct.cs    # Products with expiration dates
│   ├── AvailableProduct.cs  # Non-expirable products
│   └── Shipped.cs          # Interface for shippable items
├── Services/
│   ├── Cart.cs             # Shopping cart functionality
│   ├── Checkout.cs         # Checkout process management
│   └── Shipping.cs         # Shipping calculations
└── Program.cs              # Main application entry point
```

## 🎯 Usage Example

```csharp
// Create products
var cheese = new ExpiredProduct("Cheese", 100, 5, DateTime.Now.AddDays(5), 0.2);
var tv = new AvailableProduct("TV", 300, 3, 5);

// Create customer
var customer = new Customer("Omar", 500);

// Add items to cart
var cart = new Cart();
cart.AddItem(cheese, 2);
cart.AddItem(tv, 1);

// Process checkout
var checkout = new CheckoutService();
checkout.Checkout(customer, cart);
```

## 📊 Sample Output

```
** Shipment notice **
2x Cheese 400g
1x TV 5000g
Total package weight 5.40kg

** Checkout receipt **
2x Cheese              $200.00
1x TV                  $300.00
----------------------
Subtotal:              $500.00
Shipping:              $162.00
Total:                 $662.00

Remaining balance: -162
```

## 🔧 Key Components

### 🏪 **Product System**
- **Abstract Product Class**: Base class with common properties
- **ExpiredProduct**: Products with expiration dates and weight
- **AvailableProduct**: Non-expirable products with weight
- **Shipped Interface**: Contract for shippable items

### 🛒 **Shopping Cart**
- Add items with quantity validation
- Stock availability checking
- Cart state management (empty, clear)

### 💳 **Checkout Process**
- Balance validation
- Stock verification
- Expiration date checking
- Shipping fee calculation
- Receipt generation

### 📦 **Shipping System**
- Weight-based shipping calculations
- Grouped item display
- Professional shipment notices

## 🛡️ Error Handling

The system includes comprehensive error handling for:
- **Insufficient Stock**: When requested quantity exceeds available stock
- **Expired Products**: Products past their expiration date
- **Insufficient Balance**: When customer balance is insufficient
- **Empty Cart**: Attempting checkout with empty cart
- **Invalid Input**: Negative prices, quantities, or balances

## 🎨 Code Quality Features

- **Input Validation**: All constructors validate input parameters
- **Exception Handling**: Proper exception throwing and handling
- **Clean Code**: Well-structured and readable code
- **Type Safety**: Strong typing throughout the application
- **Professional Formatting**: Currency formatting and aligned output


## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

⭐ **Star this repository if you find it helpful!**

🔄 **Feel free to contribute and improve this e-commerce system!**
