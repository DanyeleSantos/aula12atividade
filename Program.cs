
using Aula12Atividade;

Console.WriteLine("Hello, World!");

Produto roupa = new Produto();
roupa.nome = "vestido";
roupa.preco = 200;
roupa.descricao = "longo, estampado lastex ";
roupa.quantidade = 15;
roupa.status = true;

roupa.desativa();
roupa.mostra();



Produto sapato = new Produto();
sapato.nome = "scapin";
sapato.preco= 150;
sapato.descricao = "of-white, confortável c/ amarração";
sapato.quantidade = 10;
sapato.status = true;

sapato.mostra();

Produto acessorio = new Produto();
acessorio.nome = "bolsa";
acessorio.preco = 180;
acessorio.descricao = "ajustável alça superior Simples elegante ";
acessorio.quantidade = 5;
acessorio.status = true;

acessorio.mostra();


