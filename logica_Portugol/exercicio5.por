programa
{
	inclua biblioteca Util
	
	funcao inicio()
	{

		//Escreva um algoritmo que leia um vetor com 50 posições de números inteiros e mostre somente os positivos.

		
		inteiro vetor[50]

		para(inteiro x = 0; x < 50; x++)
		{
			vetor[x] = Util.sorteia(1, 100)

			se(vetor[x] % 2 == 0)
			{
				escreva("\n", vetor[x])
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 214; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */