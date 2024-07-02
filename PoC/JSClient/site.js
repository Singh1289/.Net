$(async () => {
    const body = $("#productsTableBody");
    const products=await(await(fetch("https://localhost:44337/api/Products"))).json();
    for (const product of products) {
        let row=`
            <tr>
                <td>${product.productId}</td>
                <td>${product.productName}</td>
                <td>${product.unitPrice}</td>
                <td>${product.description}</td>
                <td>${product.discount}</td>
            </tr>
        `;
        body.append(row);
    }
});