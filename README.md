🔐 E-Commerce End-to-End Automation Framework
📌 Project Overview

This project is an automated UI testing framework for an e-commerce web application.

The framework validates core user workflows including authentication, product management, cart operations, checkout processing, and edge-case behavior.

The project is implemented using C#, NUnit, SpecFlow (BDD), and Aquality Selenium, following the Page Object Model (POM) design pattern.

🛠 Technologies Used

Programming Language: C#

Testing Framework: NUnit

BDD Framework: SpecFlow

Automation Library: Aquality Selenium

Architecture Pattern: Page Object Model

Assertion Library: NUnit Assertions

📂 Project Structure
Framework
├── Pages
│   ├── LogInPage
│   ├── ProductsPage
│   ├── CartPage
│   └── CheckoutPage
│
├── StepDefinitions
│   ├── LoginSteps
│   ├── ProductSteps
│   ├── CartSteps
│   └── CheckoutSteps
│
├── Helpers
└── Hooks
🔐 Login Module Testing

The framework validates:

Successful login workflow

Locked user access validation

Invalid credential handling

Empty field validation

🛒 Product Module Testing
Sorting Validation

Verify product price sorting (low → high)

Cart Interaction Testing

Add multiple products to cart

Random product removal

Cart badge count verification

🛍 Cart Module Testing

Verify cart item operations

Validate product removal functionality

💳 Checkout Module Testing
Validation Testing

Required field validation

Positive Workflow Testing

Complete purchase simulation

Order confirmation verification

Checkout workflow:

Add Product → Cart → Checkout → Form Input → Finish → Confirmation
🚨 Edge Case Testing

The framework also tests:

Direct inventory page access without authentication

Page refresh behavior during checkout workflow

⚙️ Setup & Running Tests
Prerequisites

.NET SDK installed

Chrome browser installed

Visual Studio recommended

Restore Dependencies
dotnet restore
Run Tests

Run all tests:

dotnet test

Run specific scenarios:

dotnet test --filter TestCategory=Login
📊 Reporting

Test execution results can be viewed using:

NUnit test output

SpecFlow documentation reports

🔧 Design Principles Applied

Separation of test logic and UI interaction

Reusable page components

Data abstraction for test inputs

BDD-style scenario specification

🔮 Future Improvements

Add API automation layer

Integrate CI/CD pipeline

Implement structured logging

Add parallel test execution

Improve test data management

👨‍💻 Project Purpose

This project is created for:

Demonstrating automation testing skills

Portfolio presentation

BDD framework practice