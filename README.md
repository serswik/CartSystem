🛒 Simple E-Commerce Shopping Cart (Console App in C#)
This is a simple console application written in C# that simulates an e-commerce shopping cart.
It allows users to add products to a cart, calculate the total cost, and check whether the total fits within a specified budget.

📁 Project Structure
Product.cs
Represents a product with a name and a price.

Cart.cs
Manages a private list of products in the cart and provides functionality to add products and calculate the total cost.

Program.cs
Main entry point of the application. Handles user interaction and the shopping flow.

✅ Features
Add products to a shopping cart by name.

View the total cost of selected products.

Enter a budget to check if your total spending fits within it.

Console-based UI for ease of use.

📌 Implementation Details
1. Product Class
Properties:

Name (string)

Price (decimal)

Constructor:
Initializes a product with a name and a price.

2. Cart Class
Private list:
Stores Product objects representing items in the cart.

Method AddProduct(Product product):
Adds a product to the cart.

Method GetTotalAmount():
Returns the total cost of all items in the cart.

3. Program Class
Main Method:

Creates a list of predefined products.

Displays products to the user.

Lets the user add products to the cart by typing their names.

Asks the user to enter a budget.

Compares the cart total with the budget:

✅ If the total is within the budget, a success message is shown.

❌ If not, a warning is displayed.

