[//]: # (|            | Decision Table   |      |  |)

[//]: # (|            | Conditions   |  Rules  |)

[//]: # (|------------|------------------|------|------------|)

[//]: # (|            | Employee Type    | USER | ADMIN |)

[//]: # (|            |  |      ||)

[//]: # (| Conditions | Can Self-Register         |)

[//]: # (|            | Can Login            |)

[//]: # (|            | Manage Sales Report           |)

[//]: # (|            | Purchase items            |)

[//]: # (|            | See user purchases           |)

[//]: # (|            | Update Inventory            |)

[//]: # (|            | Should be able to check out|      |)

[//]: # ()
[//]: # (No, this is not possible with GitHub-Flavored Markdown. As the spec explains &#40;emphasis added&#41;:)

[//]: # ()
[//]: # (The remainder of the table’s rows may vary in the number of cells. If there are a number of cells fewer than the number of cells in the header row, empty cells are inserted. If there are greater, the excess is ignored:)

[//]: # ()
[//]: # (Of course, you can always fall back to raw HTML.)

<table>
    <thead>
        <tr>
            <th colspan="4">Decision Table</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td></td>
            <td>Conditions</td>
            <td colspan=2>Rules</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td rowspan=1>Condition Stubs</td>
            <td>Account Type</td>
            <td>USER</td>
            <td>ADMIN</td>
        </tr>
        <tr>
            <td rowspan=8>Action Stubs</td>
            <td>Login</td>
            <td>Yes</td>
            <td>Yes</td>
        </tr>
        <tr>
            <td>Self-Register</td>
            <td>Yes</td>
            <td>No</td>
        </tr>
        <tr>
            <td>Manage sales report</td>
            <td>No</td>
            <td>Yes</td>
        </tr>
        <tr>
            <td>Purchase items</td>
            <td>Yes</td>
            <td>No</td>
        </tr>
        <tr>
            <td>See user purchases</td>
            <td>No</td>
            <td>Yes</td>
        </tr>
        <tr>
            <td>Update Inventory</td>
            <td>No</td>
            <td>Yes</td>
        </tr>
        <tr>
            <td>Access Database</td>
            <td>No</td>
            <td>Yes</td>
        </tr>
        <tr>
            <td>Turn user into Admin</td>
            <td>No</td>
            <td>Yes</td>
        </tr>
    </tbody>
</table>
