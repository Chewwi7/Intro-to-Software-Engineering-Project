<table>
    <thead>
        <tr>
            <th colspan="14">Data Seed Table</th>
        </tr>
    </thead>
    <tbody>
        <tr colspan="14">
            <td><strong>Users Entity</strong></td>
        </tr>
        <tr colspan="14">
            <td>UserId PK</td>
            <td>UserName</td>
            <td>Password</td>
            <td>isAdmin</td>
        </tr>
        <tr>
            <td>1</td>
            <td>admin</td>
            <td>LootXftw!</td>
            <td>1</td>
        </tr>
        <tr>
            <td>2</td>
            <td>prime_looter</td>
            <td>iL0v3Collectibles?</td>
            <td>0</td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td><strong>Inventory Entity</strong></td>
        </tr>
        <tr>
            <td>InventoryId PK</td>
            <td>InventoryName</td>
            <td>Inventory Price($)</td>
            <td>Description</td>
        </tr>
        <tr>
            <td>1</td>
            <td>Luke Skywalker's Lightsaber</td>
            <td>30,000</td>
            <td>Let the force be with you with Luke Skywalker's legendary lightsaber!</td>
        </tr>
        <tr>
            <td>2</td>
            <td>Captain America's Shield</td>
            <td>20,000</td>
            <td>Deflect, defend, and daze your opponents with this almighty shield!</td>
        </tr>
        <tr>
            <td>3</td>
            <td>Tron Identity Disc</td>
            <td>45,000</td>
            <td>Become the world's most powerful android with this special edition Identity Disc!</td>
        </tr>
        <tr>
            <td>4</td>
            <td>Tony Stark Mark III Suit</td>
            <td>1,000,000,000</td>
            <td>Fly and shoot lasers with this one of a kind Mark III suit with AI Jarvis!</td>
        </tr>
        <tr>
            <td></td>
        </tr>
<tr>
            <td><strong>Shipping Entity</strong></td>
        </tr>
        <tr>
            <td>ShippingTypeId PK</td>
            <td>ShippingName</td>
            <td>ShippingCost($)</td>
        </tr>
        <tr>
            <td>1</td>
            <td>Overnight</td>
            <td>29</td>
        </tr>
        <tr>
            <td>2</td>
            <td>3-Day</td>
            <td>19</td>
        </tr>
        <tr>
            <td>3</td>
            <td>Ground</td>
            <td>0</td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td><strong>Sales Entity</strong></td>
        </tr>
        <tr>
            <td>SalesId PK</td>
            <td>UserId</td>
            <td>InventoryId</td>
            <td>SoldDate</td>
            <td>Address</td>
            <td>PhoneNumber</td>
            <td>CreditCardNumber</td>
            <td>ExpirationDate</td>
            <td>CVV</td>
            <td>Subtotal</td>
            <td>ShippingTypeId</td>
            <td>ShippingCost</td>
            <td>Tax</td>
            <td>Total</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tbody>
</table>
