using _17Acoplamento;

ComportamentoNadar nadar = new ComportamentoNadar();
ComportamentoAndar andar = new ComportamentoAndar();

var homem = new Homem(andar);
homem.Locomocao();

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.ReadKey();