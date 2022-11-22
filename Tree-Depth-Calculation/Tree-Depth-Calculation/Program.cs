
using Tree_Depth_Calculation;
               

//Given example in pdf

Branch main = new Branch();

//Main has 2 branches
Branch b1 = new Branch();
Branch b2 = new Branch();
main.Add(b1);
main.Add(b2);

//b1 has 1 branch
Branch b1_1 = new Branch();
b1.Add(b1_1);

//b2 has 3 branches
Branch b2_1 = new Branch();
Branch b2_2 = new Branch();
Branch b2_3 = new Branch();
b2.Add(b2_1);
b2.Add(b2_2);
b2.Add(b2_3);

//b2_1 has 1 branc
Branch b2_1_1 = new Branch();
b2_1.Add(b2_1_1);

//b2_2 has 2 branches
Branch b2_2_1 = new Branch();
Branch b2_2_2 = new Branch();
b2_2.Add(b2_2_1);
b2_2.Add(b2_2_2);

//b2_2_1 has 1 branch
Branch b2_2_1_1 = new Branch();
b2_2_1.Add(b2_2_1_1);

Console.WriteLine("Tree Depth: {0}", main.GetDepth());


