using System.Collections.Generic;

namespace Projeto.Models
{
    public class Pedido
    {
         List<ItemPedido> listaDePedido = new List<ItemPedido>();
   public List<ItemPedido> Listar(){ 
return listaDePedido;
   }
   public void Adicionar(ItemPedido itemPedido)
        {
            listaDePedido.Add(itemPedido);
        }

    public double ValorTotal() {
       double total=0;
      for(int i=0; i <listaDePedido.Count; i++){total = listaDePedido[i].valor_unitario + total;}
    return total;
        }
    }
}