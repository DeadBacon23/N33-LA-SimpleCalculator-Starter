# Simple Calculator Starter

This project is a survival decision-making game inspired by the mini-series 'Station Eleven.' The game is built using JavaScript and HTML.

## Changes

### Change 1: Make Conversion Class Static
- The conversion class, which handles converting strings to integers, has been made static for simplicity and ease of access.

### Change 2: Improved Input Validation
- The program now asks for input again if the user enters an invalid number (e.g., if the user types "six" or "cat" instead of "6"). 
- The same validation is applied to operators.
- Help text is displayed to guide the user on how to correctly input valid numbers and operators. For example, it may display: 
  - `"Please enter a valid number."`
  - `"Enter '+' or 'plus' for addition, or other valid operators such as 'x', 'y', 'z'."`

### Change 3: Human-Readable Result Display
- The result is now displayed in a human-readable format, such as: 
  - `"The value 1 plus the value 2 is equal to 3."`
- String formatting and `StringBuilder` operations were used to format the output.
- The result is displayed with decimal precision of 2. For example, `10.10`.

### Change 4: Calculator Engine Class as DLL
- The `CalculatorEngine` class has been moved to its own project and compiled into a DLL.
- The DLL is now added to the main project, making it reusable for other projects as well.

### Change 5: Extra Function Implementation
- In addition to basic operations like addition, subtraction, multiplication, and division, one extra function has been implemented. (You can specify which function here).
