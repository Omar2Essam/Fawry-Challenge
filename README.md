# Fawry Quantum Internship Challenge 3

This project is a solution for the **Fawry Rise Journey - Full Stack Development Internship Challenge**.

---

## 📌 **Project Idea**

A simple **E-commerce system** that supports:
- Adding **different types of products**:
  - Products that **expire** (e.g., Cheese, Biscuits).
  - Products that **require shipping** and have weight.
  - Products that **don’t require shipping** (e.g., Scratch Cards).
- A **shopping cart** to add products in specific quantities.
- A **checkout process** that:
  - Checks available stock.
  - Checks product expiration.
  - Calculates **subtotal + shipping fees**.
  - Prints **shipment notice** and **checkout receipt**.

---

## ✅ **Main Components**

- `Product`: Base class for all products.
- `IExpirable`: Interface for products that can expire.
- `IShippable`: Interface for products that need shipping.
- `Cart`: Holds products added by the customer.
- `ShippingService`: Handles shipping notice and total weight.
- `CheckoutService`: Handles checkout logic and prints receipt.

---

## ✅ **Sample Usage**

```csharp
var cheese = new Cheese(\"Cheese\", 100, 5, DateTime.Now.AddDays(2), 0.4);
var biscuits = new Biscuits(\"Biscuits\", 150, 3, DateTime.Now.AddDays(3), 0.7);
var scratchCard = new ScratchCard(\"ScratchCard\", 50, 10);

var customer = new Customer(\"Ali\", 1000);
var cart = new Cart();

cart.Add(cheese, 2);
cart.Add(biscuits, 1);
cart.Add(scratchCard, 1);

CheckoutService.Checkout(customer, cart);
