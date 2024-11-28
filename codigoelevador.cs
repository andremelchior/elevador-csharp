using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recriando_aula_6
{

	public class Elevador
	{ //Atributos
		private int qtd_andares = 10;
		private int andar_atual;
		private int andar_destino;
		private bool porta = true;
		//Final Atributos

		//Get/Set (Construtores)
		public int Qtd_Andares
		{
			get { return qtd_andares; }
			set { qtd_andares = value; }
		}
		public int Andar_Atual
		{
			get { return andar_atual; }
			set { andar_atual = value; }
		}
		public int Andar_Destino
		{
			get { return andar_destino; }
			set { andar_destino = value; }
		}
		public bool Porta
		{
			get { return porta; }
			set { porta = value; }
		}
		//Final construtores
		//Metodos
		public void Sobe() //Adicionar +1 no anda atual, parar de adicionar quando o ultimo andar for atingido ou o andar de destino
		{
			if (Andar_Atual < Andar_Destino && Porta == false)
			{
				if (Andar_Atual == qtd_andares)
					andar_atual += 0;
				while (andar_atual != andar_destino)
				{
					andar_atual += 1;
					Console.WriteLine(&quot; Subindo... andar:{ 0}
					&quot;, andar_atual);
				}
				Console.WriteLine(&quot; O andar atual �:{ 0}\n & quot;, andar_destino);
				//Console.WriteLine(&quot;Voce foi do andar:{0} para o andar:{1}&quot;,);

			}
		}
		public void Descer() //Subtrai -1 do andar atual, para de subtrair quando o andar de destino for atingido ou t�rreo
		{
			if (Andar_Atual > Andar_Atual && Porta == false)
			{
				if (andar_atual == 0)
					andar_atual -= 0;
				while (andar_atual != andar_destino)
					andar_atual -= 1;
				Console.WriteLine(&quot; Descendo...\n & quot;);
				Console.WriteLine(&quot; O andar atual �{ 0}\n & quot;, andar_atual);

			}
		}
		public void Parar() //andar atual== andar de destino
		{
			/* if (andar_atual == andar_destino)
			{



			} */
		}
		public void Abrir_Porta() //Porta � True
		{
			if (porta == false)
				porta = true;

			Console.WriteLine(&quot; A porta est� Aberta.\n & quot;);
		}
		public void Fechar_Porta() //Porta � False
		{
			if (porta == true)
				porta = false;
			Console.WriteLine(&quot; A porta est� Fechada.\n & quot;);

		}
		public void Selecionar_Andar(int andar_selecionado) //Seta o andar de destino
		{
			andar_destino = andar_selecionado;
			Console.WriteLine(&quot; O andar de destino �:{ 0}\n & quot;, andar_destino);
		}
		public void Chamar_Elevador(int andar_onde_estou)//Seta o andar de destino
		{
			andar_destino = andar_onde_estou;
			Console.WriteLine(&quot; O Elevador foi chamado do andar: { 0}\n & quot;, andar_onde_estou);
		}
		//Final Metodos
	}
}
