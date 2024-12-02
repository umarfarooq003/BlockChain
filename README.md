# C# Blockchain-Based Data Management System

This is a C# application that demonstrates a simple implementation of blockchain concepts for managing and storing data in a database. The project leverages blockchain principles, including the use of hash and previous hash values to maintain data integrity.

## Features

### Add Data Form
- Allows users to add data to the blockchain.
- The form includes:
  - A readonly **ID** field (auto-incremented).
  - A **data input field** for the information to be stored.
- On clicking the **Add** button:
  - A new block is generated with a timestamp, hash, and reference to the previous block's hash.
  - The block is added to the SQL Server database.

### Search by ID
- Provides a form where users can input a block **ID**.
- Clicking the "Search" button fetches and displays the row related to the specified ID.

### View Entire Blockchain
- A form with a button to display all the records in the blockchain.
- Data is presented in a `DataGridView` for easy review.

## Technical Details

### Blockchain Concepts
- Each `block` is linked using a hash and previous hash.
- Ensures data integrity by chaining blocks.

### Database
- **SQL Server** is used to store the blockchain data.
- Table schema includes the following fields:
  - `ID`: Unique identifier for the block.
  - `Hash`: The block's hash value.
  - `Previous Hash`: The hash value of the previous block.
  - `DateTime`: Timestamp of block creation.
  - `Data`: The data stored in the block.

### User Interface
- Developed using **Windows Forms**.
- Simple and intuitive UI for:
  - `Adding blocks.`
  - `Searching by ID.`
  - `Viewing the entire blockchain.`

### Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/umarfarooq003/BlockChain
2. Open the project in Visual Studio.
3. Update the ConnectionString:
   - Modify the connection string in the project to match your SQL Server configuration.
4. Run the application:
   - Interact with the blockchain forms to add, search, and view blocks.
##  Project Structure
## Forms
 - **Add Data Form:** To add new data to the blockchain.
 - **Search by ID Form:** To fetch details of a specific block.
 - **View Entire Blockchain Form:** To display all stored blocks.
## Classes
 - **Block:** Represents a block in the blockchain, with properties such as:
   - `ID`
   - `Hash`
   - `PreviousHash`
   - `Data`
   - `Timestamp`
## Database
 - `SQL Server` table for storing blockchain data.
## How it Works
### Adding a Block
1. Enter data in the textbox and click "Add".
2. A block is created with:
   - Current data and timestamp.
   - A hash generated based on the block data.
   - A reference to the previous block's hash.
3. The block is saved in the SQL database.
## Searching a Block
  - Input a block `ID` to retrieve its details from the database.
## Viewing the Blockchain
  - Displays all stored blocks in a tabular format using a `DataGridView`.
## Technologies Used
  - C#
  - Windows Forms
  - SQL Server
  - ADO.NET
## Future Enhancements
  - Add block validation to verify the integrity of the blockchain.
  - Implement cryptographic hash algorithms (e.g., `SHA-256`).
  - Add functionality to export the blockchain as a `JSON file`.
## License
This project is licensed under the  **MIT License**.


