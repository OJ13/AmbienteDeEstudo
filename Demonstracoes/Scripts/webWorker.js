self.addEventListener('message', function (event) {
    var obj = JSON.parse(event.data)
    var msg;
    switch (parseInt(obj.comando)) {
        case 1:
            msg = 'Estou fazendo o backup.<br/>';
            break;
        case 2:
            msg = 'Estou Executando o calculo Matemático.<br/>';
            break;
        case 3:
            msg = 'Estou Copiando um Arquivo.<br/>';
            break;
        case 4:
            msg = 'Finalizando.<br/>';
            break;
        default:

    }
    msg += 'A mensagem foi: ' + obj.msg;

    self.postMessage(msg);

    if (parseInt(obj.comando) == 4) {
        self.close();
    }
});