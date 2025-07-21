# 🎨 Decorator Pattern Example in C#

This repository contains a simple implementation of the **Decorator Design Pattern** in C#.  
The Decorator Pattern allows you to dynamically add new behaviors or responsibilities to objects without modifying their structure.

---

## 📌 What is the Decorator Pattern?

The **Decorator Pattern** is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects (decorators) that contain the behaviors.

✅ Instead of creating subclasses for every possible combination of behaviors, you can wrap objects with multiple decorators.  
✅ This makes the code more flexible and open for extension.

---

## 📂 Project Structure

Decorator.Pattern_01/
│
├── Component.cs
│ ├── Component (abstract)
│ └── ConcreteComponent (concrete implementation)
│
├── Decorator.cs
│ ├── Decorator (abstract)
│ └── ConcreteDecorator (adds new behavior)
│
└── Program.cs (example usage)

yaml
Copy
Edit

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/<your-username>/<your-repo-name>.git
Open the solution in Visual Studio or any C# IDE.

Build and run the project.

Check the console output.

✨ Example Output
When you run the project, you will see something like this:

arduino
Copy
Edit
ConcreteComponent Operation is run...
----------------------------------------------------
ConcreteComponent Operation is run...
ConcreteDecorator Operation is running new Operation...
🔧 How It Works
🔹 Component (Abstract Class)
Defines the interface for objects that can have responsibilities added to them dynamically.

🔹 ConcreteComponent
A concrete implementation of Component that we want to decorate.

🔹 Decorator (Abstract Class)
Holds a reference to a Component object and implements the same interface.
It delegates work to the wrapped component.

🔹 ConcreteDecorator
Extends the behavior of Component by adding new operations before/after delegating to the base Operation().

📖 Code Highlight
csharp
Copy
Edit
ConcreteComponent concreteComponent = new ConcreteComponent();
concreteComponent.Operation();

Console.WriteLine("----------------------------------------------------");

ConcreteComponent concreteComponent2 = new ConcreteComponent();
ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent2);
concreteDecorator.Operation();
✅ Why Use This Pattern?
✔️ Open/Closed Principle: You can extend behavior without modifying existing code.
✔️ Flexibility: Combine multiple decorators dynamically.
✔️ Reusability: Common behavior can be shared across decorators.

💡 Notes
In this example, _component in Decorator is declared as private readonly for immutability.

You can change it to protected if you want child classes to have direct access and be able to modify it.

📌 License
This project is open source and available under the MIT License.

Made with ❤️ for learning Design Patterns

yaml
Copy
Edit

---
