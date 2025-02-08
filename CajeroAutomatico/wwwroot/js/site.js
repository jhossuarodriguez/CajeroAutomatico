function retirarDinero() {
    var monto = document.getElementById("monto").value;

    fetch('/Cajero/RetirarDinero', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ monto: monto })
    })
        .then(response => response.json())
        .then(data => {
            var lista = document.getElementById("listaBilletes");
            lista.innerHTML = "";
            for (var billete in data) {
                var item = document.createElement("li");
                item.className = "list-group-item";
                item.textContent = billete + " : " + data[billete] + " billetes";
                lista.appendChild(item);
            }

            var modal = new bootstrap.Modal(document.getElementById('resultadoModal'));
            modal.show();
        })
        .catch(error => console.error("Error:", error));
}