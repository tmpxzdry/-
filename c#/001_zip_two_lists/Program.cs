using System;

namespace _001_zip_two_lists{
    class Node{
        public int val;
        public Node next;
    }
    class Program{
        static void Main(string[] args){
            var list1=MakeList(1,3,5,7,7,9);
            var list2=MakeList(2,6,7,8);
            // PrintList(list1);
            // PrintList(list2);
            var result=Zip(list1,list2);
            PrintList(result);
        }

        static Node Zip(Node p,Node q){
            //找到头元素,dummy head
            Node head=new Node(),zipper=head;//最后会返回head.next，不引用head，会自动回收不影响性能
            while(p!=null&&q!=null){
                if(p.val<=q.val){
                    zipper.next=p;
                    p=p.next;
                }else{
                    zipper.next=q;
                    q=q.next;
                }
                zipper=zipper.next;
            }
            zipper.next=p??q;
            // zipper.next=p==null?q:p;
            return head.next;
        }

        static Node MakeList(params int[] a){
            Node head=null;
            for(int i=a.Length-1;i>=0;i--)
                head=new Node{val=a[i],next=head};
            return head;
        }

        static void PrintList(Node list){
            while(list!=null){
                System.Console.Write($"{list.val}->");
                list=list.next;
            }

            System.Console.WriteLine("null");
        }
    }
}








//修改前
// using System;

// namespace _001_zip_two_lists{
//     class Node{
//         public int val;
//         public Node next;
//     }
//     class Program{
//         static void Main(string[] args){
//             var list1=MakeList(1,3,5,7,7,9);
//             var list2=MakeList(2,6,7,8);
//             // PrintList(list1);
//             // PrintList(list2);
//             var result=Zip(list1,list2);
//             PrintList(result);
//         }

//         static Node Zip(Node p,Node q){
//             //找到头元素,dummy head
//             Node head=new Node(),zipper=head;//最后会返回head.next，不引用head，会自动回收不影响性能
//             while(true){
//                 //保护逻辑
//                 if(p==null){
//                     zipper.next=q;
//                     break;
//                 }
//                 if(q==null){
//                     zipper.next=p;
//                     break;
//                 }
//                 if(p.val<=q.val){
//                     zipper.next=p;
//                     p=p.next;
//                 }else{
//                     zipper.next=q;
//                     q=q.next;
//                 }
//                 zipper=zipper.next;
//             }
//             return head.next;
//         }

//         static Node MakeList(params int[] a){
//             Node head=null;
//             for(int i=a.Length-1;i>=0;i--)
//                 head=new Node{val=a[i],next=head};
//             return head;
//         }

//         static void PrintList(Node list){
//             while(list!=null){
//                 System.Console.Write($"{list.val}->");
//                 list=list.next;
//             }

//             System.Console.WriteLine("null");
//         }
//     }
// }
