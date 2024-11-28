using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSElevador
{
	class Elevador
	{
		private int andares = 0;
		public int andar_atual;
		public int andar_destino;
		private int andar_total = 0;
		private int pessoas;
		private int qtdPessoas;
		private int total_pessoas;
		int opcao;

		//Get/Set (Propriedades)
		public int Andar_Atual
		{
			get
			{
				return andar_atual;
			}
			set
			{
				andar_atual = value;
			}
		}

		public int Andar_Destino
		{
			get
			{
				return andar_destino;
			}
			set
			{
				andar_destino = value;
			}
		}

		public Elevador(int capacidade, int total_andares) //construtor
		{
			this.total_pessoas = capacidade;
			this.andar_total = total_andares;
		}

		public void menu() //chama o menu das op��es
		{
			Console.Clear(); // Limpa Tela
			Console.WriteLine("\n Programa: Elevador de pr�dio \n");
			Console.WriteLine("\n Digite uma op��o: \n");
			Console.WriteLine("\n   -  -  -  -  -  -  -  ");
			Console.WriteLine("\n |   (1) - ENTRAR     |\n");
			Console.WriteLine("\n |   (2) - SAIR       |\n");
			Console.WriteLine("\n |   (3) - SUBIR      |\n");
			Console.WriteLine("\n |   (4) - DESCER     |\n");
			Console.WriteLine("\n |   (Q) - QUIT       |\n");
			Console.WriteLine("   -  -  -  -  -  -  -   \n");
		}

		public void Entrar() //Entrar no elevador
		{
			if (this.andar_destino > 0) //Dados do elevador
			{
				Console.WriteLine("Andar: " + this.andar_atual + "�");
			}
			else
			{
				Console.WriteLine("Andar atual: T�rreo");
			}

			Console.WriteLine("A capacidade do elevador � de 5 pessoas");
			Console.WriteLine("Total de Pessoas no elevador: {0}", this.pessoas);
			Console.WriteLine("\nPressione ENTER para continuar.");
			Console.ReadKey();

			try
			{
				Console.Clear();
				Console.WriteLine("\n Deseja realmente entrar no elevador?\n");
				Console.WriteLine("\n  -  -  -  -  -  -  ");
				Console.WriteLine("\n |   (1) - SIM    |\n");
				Console.WriteLine("\n |   (2) - N�O    |\n");
				Console.WriteLine("  -  -  -  -  -  -  \n");
				opcao = int.Parse(Console.ReadLine());

				if (opcao.Equals(1))
				{
					if (this.qtdPessoas < this.total_pessoas)
					{
						Console.Clear();
						Console.WriteLine("Digite a quantidade de pessoas que v�o entrar: \n");
						this.qtdPessoas = int.Parse(Console.ReadLine());
						this.pessoas = this.qtdPessoas + this.pessoas;

						if (this.pessoas <= this.total_pessoas)
						{
							Console.Clear();
							Console.WriteLine("H� " + this.pessoas + " pessoas no elevador \n");
							Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
							Console.ReadKey();
							Console.Clear();
						}
						else
						{
							this.qtdPessoas = this.pessoas - this.total_pessoas;
							Console.Clear();
							Console.WriteLine("Opa! h� muitas pessoas, deve sair {0} ", this.qtdPessoas + " pessoas \n");
							Console.WriteLine("Pressione ENTER para voltar ao menu e remova {0} pessoas. \n", this.qtdPessoas);
							Console.ReadKey();
							Console.Clear();
						}
					}
					else
					{
						Console.Clear();
						Console.WriteLine("\nErro! j� atingimos o m�ximo de pessoas. \n");
						Console.WriteLine("Pressione ENTER para voltar ao menu e remover mais pessoas para poder entrar. \n");
						Console.ReadKey();
						Console.Clear();
					}
				}
				else if (opcao.Equals(2))
				{
					Console.Clear();
					Console.WriteLine("Ok! voltando para o menu... \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
					Console.ReadKey();
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Erro! Op��o incorreta. \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
					Console.ReadKey();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("\n\nHouve um erro! consulte: \n");
				Console.WriteLine(e.ToString());
				Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
				Console.ReadKey();
			}
		}

		public void Sair() //Sair do elevador
		{
			try
			{
				Console.WriteLine("\n Deseja realmente sair do elevador?\n");
				Console.WriteLine("\n  -  -  -  -  -  -  ");
				Console.WriteLine("\n |   (1) - SIM    |\n");
				Console.WriteLine("\n |   (2) - N�O    |\n");
				Console.WriteLine("  -  -  -  -  -  -  \n");

				opcao = int.Parse(Console.ReadLine());

				if (opcao.Equals(1))
				{
					if (this.pessoas > 0)
					{
						Console.Clear();
						Console.WriteLine("Total de Pessoas: {0} \n", this.pessoas);
						Console.WriteLine("Digite a quantidade de pessoas que ir�o sair: \n");
						this.qtdPessoas = int.Parse(Console.ReadLine());
						this.pessoas = this.pessoas - this.qtdPessoas;

						if (this.pessoas <= this.total_pessoas)
						{
							Console.Clear();
							Console.WriteLine("H� {0} pessoas no elevador \n", this.pessoas);
							Console.WriteLine("\nPressione ENTER para voltar ao menu. \n");
							Console.ReadKey();
							Console.Clear();
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Opa! ainda h� muitas pessoas. \n");
							Console.WriteLine("Pressione ENTER para voltar ao menu e remover mais pessoas. \n");
							Console.ReadKey();
							Console.Clear();
						}
					}
					else
					{
						Console.WriteLine("\nErro! o elevador est� vazio. \n");
						Console.WriteLine("Pressione ENTER para voltar ao menu e adicionar mais pessoas. \n");
						Console.ReadKey();
						Console.Clear();
					}
				}
				else if (opcao.Equals(2))
				{
					Console.Clear();
					Console.WriteLine("Ok! voltando para o menu... \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
					Console.ReadKey();
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Erro! Op��o incorreta. \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
					Console.ReadKey();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("\n\nHouve um erro! consulte: \n");
				Console.WriteLine(e.ToString());
				Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
				Console.ReadKey();
			}
		}

		public void Subir() //Sobe os andares
		{
			try
			{
				if (this.pessoas <= 5)
				{
					Console.WriteLine("Digite um andar para subir: \n");
					this.Andar_Destino = int.Parse(Console.ReadLine());

					if (this.Andar_Destino > this.andares)
					{
						if (this.Andar_Destino > this.Andar_Atual)
						{
							if (this.Andar_Destino <= this.andar_total)
							{
								Console.WriteLine("\nVoc� est� subindo! \n");
								Console.ReadKey();
								Console.Clear();
								Console.WriteLine("Voc� chegou ao seu destino! Andar: {0} \n", this.Andar_Destino);
								Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
								this.Andar_Atual = this.Andar_Destino;
								Console.ReadKey();
								Console.Clear();
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Erro ao tentar subir! O limite de andares j� foi alcan�ado. \n");
								Console.WriteLine("OBS: O elevador vai at� o 5� andar, digite um andar v�lido. \n");
								Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
								Console.ReadKey();
								Console.Clear();
							}
						}
						else
						{
							Console.Clear();
							Console.WriteLine("Erro! Digite um n�mero de andar maior que {0} \n", this.Andar_Atual);
							Console.WriteLine("OBS: Se j� estiver no 5� andar ter� que descer, pois o 5� � o �ltimo. \n");
							Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
							Console.ReadKey();
							Console.Clear();
						}
					}
					else if (this.Andar_Destino == 0 && this.Andar_Atual == 0)
					{
						Console.Clear();
						Console.WriteLine("Voc� j� est� no t�rreo! Digite um n�mero de andar maior que 0. \n");
						Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
						Console.ReadKey();
					}
					else
					{
						Console.Clear();
						Console.WriteLine("Erro! Tente novamente! \n");
						Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
						Console.ReadKey();
					}
				}
				else
				{
					Console.WriteLine("Erro! o limite de pessoas no elevador � 5, remova mais pessoas para poder subir \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
					Console.ReadKey();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("\n\nHouve um erro! consulte: \n");
				Console.WriteLine(e.ToString());
				Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
				Console.ReadKey();

			}
		}

		public void Descer() // Descer para outros andares
		{
			try
			{
				if (this.pessoas <= 5)
				{
					Console.WriteLine("Digite um andar para descer: \n");
					this.Andar_Destino = int.Parse(Console.ReadLine());


					if (this.Andar_Destino > this.andares)
					{
						if (this.Andar_Destino < this.Andar_Atual)
						{
							if (this.Andar_Destino < this.andar_total)
							{
								Console.WriteLine("\nVoc� est� descendo! \n");
								Console.ReadKey();
								Console.Clear();
								Console.WriteLine("Voc� chegou ao seu destino! Andar: {0} \n", this.Andar_Destino);
								Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
								this.Andar_Atual = this.Andar_Destino;
								Console.ReadKey();
								Console.Clear();
							}
							else
							{
								Console.WriteLine("\nErro! N�o foi poss�vel descer, andar inv�lido. \n");
								Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
								Console.ReadKey();
								Console.Clear();
							}
						}
						else
						{
							Console.WriteLine("\nErro! Digite um n�mero de andar menor do que {0}. \n", this.Andar_Atual);
							Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
							Console.ReadKey();
							Console.Clear();
						}
					}
					else if (Andar_Destino.Equals(0))
					{

						Console.WriteLine("\nIndo para o t�rreo... \n");
						Console.ReadKey();
						Console.Clear();
						Console.WriteLine("Voc� chegou ao seu destino! Andar: T�rreo \n");
						Console.WriteLine("Pressione ENTER para voltar ao menu. \n");
						Console.ReadKey();
						this.Andar_Atual = this.Andar_Destino;
					}
					else
					{
						Console.WriteLine("\nErro! \n");
						Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
						Console.ReadKey();
					}
				}
				else
				{
					Console.WriteLine("Erro! o limite de pessoas no elevador � 5, remova mais pessoas para poder descer \n");
					Console.WriteLine("Pressione ENTER para voltar ao menu e tente novamente. \n");
					Console.ReadKey();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("\n\nHouve um erro! consulte: \n");
				Console.WriteLine(e.ToString());
				Console.WriteLine("\nPressione ENTER para voltar ao menu e tente novamente. \n");
				Console.ReadKey();
			}
		}
	}
}