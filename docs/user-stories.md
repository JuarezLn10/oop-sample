# User Stories

This document contains user stories for the main features of the application.

## US001: Create a Purchase Order
**As a** procurement manager, \
**I want to** create a purchase order for a supplier, \
**So that** I can manage the procurement process efficiently.

### Acceptance criteria
### Scenario 1: Create a Purchase Order with Valid Supplier
**Given** a supplier with code "SUP123", name "Microsoft; Inc.", and address "Redmond 110, NY, USA", \
**When** the procurement manager creates a purchase order with the supplier, \
**Then** the purchase order should be created successfully with the supplier's details.
### Scenario 2: Create a Purchase Order with Invalid Supplier
**Given** a supplier with code "SUP123", name "Microsoft; Inc.", and address "Redmond 110, NY, USA", \
**When** the procurement manager creates a purchase order with an invalid supplier code "SUP999", \
**Then** the system should throw an exception indicating that the supplier does not exist.