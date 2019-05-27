function Node(data) {
    this.data = data
    this.left = null;
    this.right = null;
}

let n1 = new Node(5);
let n2 = new Node(6);
let n3 = new Node(7);
let n4 = new Node(8);

n1.left = n2;
n1.right = n3;
n2.left = n4;
n2.right = null;
n3.left = null;
n3.right = null;
n4.left = null;
n4.right = null;

//先序遍历 根左右
let arr = []
function preorder(node) {
    if (node != null) {
        arr.push(node.data);
        preorder(node.left);
        preorder(node.right);
    }
    return arr;
}
let tree = preorder(n1);
console.log(tree);

//中序遍历 左根右
arr = [];
function inorder(node) {
    if (node != null) {
        inorder(node.left);
        arr.push(node.data);
        inorder(node.right);
    }
    return arr;
}
tree = inorder(n1);
console.log(tree);

//后序遍历 左右根
arr=[]
function postorder(node){
    if(node){
        postorder(node.left);
        postorder(node.right);
        arr.push(node.data);
    }
    return arr
}
tree = postorder(n1);
console.log(tree);