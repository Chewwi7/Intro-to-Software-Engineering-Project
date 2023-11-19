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
            <td>Relate to ContentGroup.UserId</td>
        </tr>
        <tr>
            <td>UserName</td>
            <td>varchar(40)</td>
            <td></td>
            <td>False</td>
            <td>Relate to ContentGroup.UserName</td>
        </tr>
        <tr>
            <td>UserEmail</td>
            <td>nvarchar(255)</td>
            <td></td>
            <td>False</td>
            <td>Relate to ContentGroup.UserEmail</td>
        </tr>
        <tr>
            <td>UserPassword</td>
            <td>nvarchar(255)</td>
            <td></td>
            <td>False</td>
            <td>Relate to ContentGroup.UserPassword</td>
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
            <td>Relate to ContentGroup.InventoryId</td>
        </tr>
        <tr>
            <td>InventoryName</td>
            <td>varchar 255</td>
            <td></td>
            <td>False</td>
            <td>Relate to ContentGroup.InventoryName</td>
        </tr>
        <tr>
            <td>InventoryDescription</td>
            <td>nvarchar(255)</td>
            <td>Empty ""</td>
            <td>True</td>
            <td>Relate to ContentGroup.InventoryDescription</td>
        </tr>
        <tr>
            <td>InventoryPrice</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to ContentGroup.InventoryPrice</td>
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
            <td>Relate to ContentGroup.ShippingTypeId</td>
        </tr>
        <tr>
            <td>ShippingName</td>
            <td>varchar 255</td>
            <td></td>
            <td>False</td>
            <td>Relate to ContentGroup.ShippingName</td>
        </tr>
        <tr>
            <td>ShippingCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to ContentGroup.ShippingCost</td>
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
        </tr>
        <tr>
            <td>UserId</td>
            <td>Foreign key, integer</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to User.UserId</td>
        </tr>
        <tr>
            <td>InventoryId</td>
            <td>Foreign key, integer</td>
            <td>AUTO_INCREMENT</td>
            <td>False</td>
            <td>Relate to Inventory.InventoryId</td>
        </tr>
        <tr>
            <td>UserName</td>
            <td>nvarchar(255)</td>
            <td></td>
            <td></td>
            <td>Relate to User.UserName</td>
        </tr>
        <tr>
            <td>InventoryName</td>
            <td>nvarchar(255)</td>
            <td></td>
            <td></td>
            <td>Relate to Inventory.InventoryName</td>
        </tr>
        <tr>
            <td>InventoryPrice</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to Inventory.InventoryPrice</td>
        </tr>
        <tr>
            <td>ShippingCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to Shipping.ShippingCost</td>
        </tr>
        <tr>
            <td>TotalCost</td>
            <td>decimal</td>
            <td>0.00</td>
            <td>True</td>
            <td>Relate to ContentGroup.TotalCost</td>
        </tr>
        <tr>
            <td>DateOfPurchase</td>
            <td>DATETIME</td>
            <td></td>
            <td></td>
            <td>Relate to ContentGroup.DateOfPurchase</td>
        </tr>
    </tbody>
</table>
