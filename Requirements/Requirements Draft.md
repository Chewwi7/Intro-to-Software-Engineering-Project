Philips:
-   Version 1
    -   Milestone: Initial Release
        -   Epic: User Registration and Login Page [T7E-1]
            -   Story: User Registration [T7S-1]
                -   Priority: Must Have
                -   Estimated Effort: 3 days
                -   Functional Requirement
                -   Description: The user must be able to self-register with a unique username and a 6-character minimum password.
               - Story: User Login
	              - Priority: Must Have
	              -  Estimated Effort: 3 days
	              - Functional Requirement
	              - Description: The user must be able to log in with their created username and password and be directed to the main inventory screen after pressing the login button. 
	       - Epic: Inventory Screen [T7E-2]
		       - Story: Inventory Sorting
			       - Priority: Must Have
			       - Estimated Effort:
			       - Functional Requirement
			       - Description: The user must be able to see a list of all available inventory sorted by highest to lowest price.
		       - Story: Inventory Listing
			       - Priority: Must Have
			       - Estimated Effort:
			       - Functional Requirement
			       - Description: Each inventory listing must display the item's name, picture, price, a brief description, and a button to add the item to the shopping cart. All prices must be in US dollars and formatted with a $ sign, commas, and decimal points.
			   - Story: Checkout Button
			       - Priority: Must Have
			       - Estimated Effort: 
			       - Functional Requirement
			       - Description: The user must be able to click a Checkout button to start the checkout process. The user cannot click Checkout if the shopping cart is empty.     	
	           - Story: Search Bar
		           - Priority: Must Have
		           - Estimated Effort:
		           - Functional Requirement
		           - Description: The user must be able to search the available inventory by typing in a search box.
        
Jefferys:
# Version 1
## Checkout Page
1. List Everything in Cart
	* Must Have
	* How long?
	* Functional
	* The user will be able to see every item in their cart and the subtotal cost in USD.
2. Remove Items from Cart
	* Must Have
	* How long?
	* Functional
	* The user will be able to remove items from the list in their cart. If the user removes all items they will be taken back to the main screen.
3. Pay Now Button
	* Must Have
	* How long?
	* Functional
	* The user will be able to click the pay now button to be taken to the payment screen.
4. Return to Shopping Button
	* Must Have
	* How long?
	* Functional
	* The user will be able to click the return to shopping button to return to the main screen
## Pay Now Page
1. Input Personal Information
	* Must Have
	* How long?
	* Functional
	* The user will be required to input their shipping address, credit card number, phone number, and shipping speed. The credit card also requires the expiration month and year and the CVV security code
2. Select Shipping Options
	* Must Have
	* How long?
	* Functional
	* The user will be able to select from three shipping options; Overnight: $29, 3-Day: $19, and Ground: $0/Free.
3. Confrim Order Button
	* Must Have
	* How long?
	* Functional
	* The user will be able to click a confirm order button once all fields are filled out.
## Confirm Order Page
1. List of Items User is Purchasing
	* Must have
	* How long?
	* Functional
	* The user will be able to see a list of all the items' names and prices that they are purchasing.
2. Cost Display
	 * Must have
	 * How long?
	 * Functional
	 * The user will be able to see the subtotal, tax (6% of subtotal), shipping speed cost, and the grand total. Grand total formula: subtotal + (subtotal*.06) + shipping speed cost = grand total. 
3. Complete Order Button
	* Must have
	* How long?
	* Functional
	* The user can click this button to complete their order and display a receipt of what they purchased. This button will also take the items out of inventory. 
4. Complete Order Receipt
	* Must have
	* How long?
	* Functional
	* The user will be able to see the receipt that looks almost the same as the confirm order page but also includes the last 4 digits of the users credit card number and their shipping address. The receipt will include an ok button to exit the receipt and return to the main page.
5. Return to Checkout Page Button
	* Must have
	* How long?
	* Functional
	* The user can click this button to return to the checkout page. The button will dissapear once the complete order button is clicked since their is nothing to checkout anymore.
6. Return to Main Page Button
	* Must have
	* How long?
	* Functional
	* The user can click this button to return to the main page. The button will dissapear once the complete order button is clicked since their is nothing to checkout anymore.
## Administrator Powers
1. Turning User into Admin
	* Must have
	* How long?
	* Functional
	* An admin can manually create new admins by turning previous users into admins.
2. Run Sales Report
	* Must have
	* How long?
	* Functional
	* An admin can run a sales report that shows everything purchased and who purchased it.
3. Adding Inventory
	* Must have
	* How long?
	* Functional
	* An admin can manually input new items into the database.
# Version 2
## Quality of Life Improvements
1. Email receipts to Users
	* Want to Have
	* How long?
	* Functional
	* After the user clicks the complete order button, they will be emailed the same receipt they are shown on the website.

//I think Admin UX should be a milestone?
## Administrator Powers
1. Sales report CSV
	* Need to Have
	* How long?
	* Functional
	* An admin can export the sales report to a CSV file to be used in excel.
2. Individual Item Receipt
	* Want to Have
	* How long?
	* Functional
	* An admin will click on a sold item and be able to see the receipt related to said item.
3. Adding Inventory with UI
	* Want to Have
	* How long?
	* Functional
	* An admin can add inventory through the website by opening a page and adding information and a picture.
4. Admin creation UI
	* Want to Have
	* How long?
	* Functional
	* A user can be turned into an admin through a UI in the application.
