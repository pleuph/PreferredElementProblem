# PreferredElementProblem

## Initial observations

### Data model

A Brick has:
- Design id, number, describes the shape of the brick - Segmented number system? Revisions with same id? May need other unique id.
- Color codes, list, describes colors of brick surfaces, order is important - Corresponds to a 3D surface (top, bottom, front, back etc.)?

An Item has:
- Item id, integer, unique id.
- Bricks, list, is a list of bricks for the items where the order is not important.

MasterData has:
- Link to one item - foreign key.
- Price - Different currencies and markets? History?
- Status, one of four values in desending order of 'quality':
  - Normal
  - Novelty
  - Outgoing
  - Discontinued
Status history?
  
### Services

Two services (endpoints) are proposed:
- MasterDataList, lists master data
- ItemList, lists items - It is noted that multiple items can have the same list of bricks.

### Problem description
Take a list of bricks and provide one item with that list of bricks. If multiple items with that list of bricks exist, pick the one with the highest status and lowest price. Status weighs higher than price.

### Notes
Test data should be generated - Unit tests, end-to-end tests, or both?
Important factors are: 
- Architecture
- Data structures
- Algorithms
- Testability
- Performance
- Correctness

## Tasks
- Architectural decisions
- Data model design and implementation
- Service and query design and implementation
- Test data generation

## Solution architecture
The solution will be implemented as a proof of concept using the technologies most familiar to the developer. This means it will contain the following: 
- A dotnet WebApi 
- An SQL database
- Entity framework migrations
- Controller endpoints serving json

Depending on the scalability needs and additional complexity of a real world solution, several options should be considered:
- A NoSql or BLOB-based data storage could provide better performance for large amounts of data.
- Separation of functionality into domains.
- An event store could be useful for preservation of historical development of price, status and more.
