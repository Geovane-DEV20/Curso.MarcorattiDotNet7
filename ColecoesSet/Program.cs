
// HashSet > Nao permite a inclusao de elementos duplicados
// Permite acesso rápido aos elementos
// Nao garante a ordem dos elementos




var frutas = new HashSet<string>();
frutas.Add{"uva", "banana", "pera"};





//Sem Duplicatas: O HashSet não permite a inclusão de elementos duplicados. Se você tentar adicionar um elemento que já existe, a operação será ignorada.

//Acesso Rápido: Devido à sua implementação baseada em tabela de hash, o acesso, inserção e remoção de elementos em um HashSet são operações de tempo constante em média, proporcionando um desempenho eficiente para essas operações.

//Não Ordenado: O HashSet não mantém a ordem de inserção dos elementos. Se você precisa de uma coleção ordenada, deve considerar usar List ou SortedSet em vez de HashSet.

//Operações Conjuntas: O HashSet fornece métodos eficientes para realizar operações conjuntas, como união, interseção e diferença entre conjuntos.

//Iteração Eficiente: Você pode iterar pelos elementos de um HashSet de maneira eficiente usando um loop foreach.