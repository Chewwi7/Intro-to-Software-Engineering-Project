<table>
    <thead>
        <tr>
            <th colspan="6">User Entity</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Property</td>
            <td>Type</td>
            <td>Default</td>
            <td>Nullable</td>
            <td>Relationship</td>
            <td>Notes</td>
        </tr>
        <tr>
            <td>UserId</td>
            <td>Primary Key, integer, identity</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Sales.UserId</td>
            <td> </td>
        </tr>
        <tr>
            <td>UserName</td>
            <td>varchar(255)</td>
            <td>NoName</td>
            <td>False</td>
            <td>Relate to Sales.UserName</td>
            <td> </td>
        </tr>
        <tr>
            <td>UserEmail</td>
            <td>nvarchar(255)</td>
            <td>NoEmail</td>
            <td>False</td>
            <td>N/A</td>
            <td> </td>
        </tr>
        <tr>
            <td>UserPassword</td>
            <td>varchar(255)</td>
            <td>NoPassword</td>
            <td>False</td>
            <td>N/A</td>
            <td> </td>
        </tr>
        <tr>
            <td>IsAdmin</td>
            <td>integer</td>
            <td>0</td>
            <td>False</td>
            <td>N/A</td>
            <td> </td>
        </tr>
    </tbody>
</table>
<br>
<table>
    <thead>
        <tr>
            <th colspan="6">Inventory Entity</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Property</td>
            <td>Type</td>
            <td>Default</td>
            <td>Nullable</td>
            <td>Relationship</td>
            <td>Notes</td>
        </tr>
        <tr>
            <td>InventoryId</td>
            <td>Primary Key, integer, identity</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Sales.InventoryId</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryName</td>
            <td>varchar(255)</td>
            <td>NoName</td>
            <td>False</td>
            <td>Relate to Sales.InventoryName</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryDescription</td>
            <td>nvarchar(255)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>N/A</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryPrice</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to Sales.InventoryPrice</td>
            <td> </td>
        </tr>
    </tbody>
</table>
<br>
<table>
    <thead>
        <tr>
            <th colspan="6">Shipping Entity</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Property</td>
            <td>Type</td>
            <td>Default</td>
            <td>Nullable</td>
            <td>Relationship</td>
            <td>Notes</td>
        </tr>
        <tr>
            <td>ShippingTypeId</td>
            <td>Primary Key, integer, identity</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Sales.ShippingTypeId</td>
            <td> </td>
        </tr>
        <tr>
            <td>ShippingName</td>
            <td>nvarchar(100)</td>
            <td>NoName</td>
            <td>False</td>
            <td>Relate to ContentGroup.ShippingName</td>
            <td> </td>
        </tr>
        <tr>
            <td>ShippingCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to ContentGroup.ShippingCost</td>
            <td> </td>
        </tr>
    </tbody>
</table>
<br>
<table>
    <thead>
        <tr>
            <th colspan="6">Sales Entity</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Property</td>
            <td>Type</td>
            <td>Default</td>
            <td>Nullable</td>
            <td>Relationship</td>
            <td>Notes</td>
        </tr>
        <tr>
            <td>SalesId</td>
            <td>Primary Key, integer, identity</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to User.UserId and Inventory.InventoryId</td>
            <td> </td>
        </tr>
        <tr>
            <td>UserId</td>
            <td>Foreign key, integer</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to User.UserId</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryId</td>
            <td>Foreign key, integer</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Inventory.InventoryId</td>
            <td> </td>
        </tr>
        <tr>
            <td>UserName</td>
            <td>varchar(255)</td>
            <td>NoName</td>
            <td>False</td>
            <td>Relate to User.UserName</td>
            <td> </td>
        </tr>
        <tr>
            <td>PhoneNumber</td>
            <td>varchar(30)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryName</td>
            <td>varchar(255)</td>
            <td>NoName</td>
            <td></td>
            <td>Relate to Inventory.InventoryName</td>
            <td> </td>
        </tr>
        <tr>
            <td>InventoryPrice</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to Inventory.InventoryPrice</td>
            <td> </td>
        </tr>
        <tr>
            <td>ShippingTypeId</td>
            <td>Foreign Key, integer</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Shipping.ShippingTypeId</td>
            <td> </td>
        </tr>
        <tr>
            <td>ShippingCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to Shipping.ShippingCost</td>
            <td> </td>
        </tr>
        <tr>
            <td>TotalCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to ContentGroup.TotalCost</td>
            <td> </td>
        </tr>
        <tr>
            <td>DateOfPurchase</td>
            <td>DATETIME</td>
            <td>getDate()</td>
            <td>True</td>
            <td>Relate to ContentGroup.DateOfPurchase</td>
            <td> </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>varchar(255)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>CreditCardNumber</td>
            <td>varchar(255)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>CVV</td>
            <td>varchar(4)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>ExpirationDate</td>
            <td>varchar(255)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>Subtotal</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>Tax</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
        <tr>
            <td>Total</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Unique to Sales</td>
            <td> </td>
        </tr>
    </tbody>
</table>
