$(document).ready(function() {
    var currentDate = new Date().toISOString().slice(0, 10);
    $("#date").val(currentDate);
});

function multiplyUnitCostSale(productId = "") {
    debugger
    if (productId === "") {
        var unitCost = document.getElementById("UnitCost").value;
        var unitCostSale = document.getElementById("UnitCostSale").value;
        var total = unitCost * unitCostSale;
        $("#Total").val(total);
    }
    else {

        var unitCost = document.getElementById("UnitCost-" + productId).value;
        var unitCostSale = document.getElementById("UnitCostSale-" + productId).value;
        var total = unitCost * unitCostSale;
        console.log(unitCost)
        console.log(unitCostSale)
        console.log("Resultado de Total: " + total)
        $("#Total-" + productId).val(total);
    }
}

function multiplyCostSaleTotal(productId = "") {
    debugger
    if (productId === "") {
        var stock = document.getElementById("Stock").value;
        var unitCost = document.getElementById("UnitCost").value;
        var unitCostSale = document.getElementById("UnitCostSale").value;
        var total = unitCost * unitCostSale;
        $("#CostSaleTotal").val(total * stock);
    }
    else {

        var stock = document.getElementById("Stock-" + productId).value;
        var unitCost = document.getElementById("UnitCost-" + productId).value;
        var unitCostSale = document.getElementById("UnitCostSale-" + productId).value;
        var total = unitCost * unitCostSale;
        console.log(unitCost)
        console.log(unitCostSale)
        console.log("Resultado de costo Total: " + total)
        $("#CostSaleTotal-" + productId).val(total * stock);
    }
}
