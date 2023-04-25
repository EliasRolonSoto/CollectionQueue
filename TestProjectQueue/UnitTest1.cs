namespace TestProjectQueue
{
    public class UnitTest1
    {
        
        [Fact]
        public void AgregarElementosAQueue()
        {
            //Instanciamos una lista
            Queue<int> q = new Queue<int>();

            // Agregamos los elementos a la lista Queue
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // Condicion de comparacion usando Count para contar elementos en la Cola
            Assert.Equal(3, q.Count);
        }

        public void RemoverElementosDeQueue()
        {
            // Instanciamos y agregamos elementos
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // removemos elementos puntuales (dequeue elimina y muestra el elemento eliminado)
            int item1 = q.Dequeue();
            int item2 = q.Dequeue();

            // Condiciones de verdad
            Assert.Equal(1, item1);
            Assert.Equal(2, item2);
            Assert.Equal(1, q.Count);
        }
        [Fact]
        public void PeekRetornaValorPeroNoElimina()
        {
            // Instanciamos y agregamos elementos
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // Con peek mostramos el elemento sin eleminarlo
            int item = q.Peek();

            // Validacion
            Assert.Equal(1, item);
            Assert.Equal(3, q.Count);
        }


    }


}








    

