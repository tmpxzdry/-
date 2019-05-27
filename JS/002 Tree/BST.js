function Node(data) {
    this.data = data;
    this.left = null;
    this.right = null;
}

function Tree(root) {
    this.root = root;
}

function insert(tree, val) {
    let node = new Node(val);

    if (!tree.root) {
        tree.root = node;
    } else {
        let tmp = tree.root;
        while (tmp) {
            if (val < tmp.data) {
                if (!tmp.left) {
                    tmp.left = node;
                    return;
                } else {
                    tmp = tmp.left;
                }
            } else {
                if (!tmp.right) {
                    tmp.right = node;
                    return;
                } else {
                    tmp = tmp.right;
                }
            }
        }
    }
}
let arr = []
let ins = [6, 3, 8, 2, 5, 1, 7];
let tree = new Tree();
tree.root = null;

ins.forEach(el => {
    insert(tree,el);
})

let result = preorder(tree.root);
console.log(result);

arr = [];
result = inorder(tree.root);
console.log(result);
//先序遍历 根左右
function preorder(node) {
    console.log(node);
    if (node != null) {
        arr.push(node.data);
        preorder(node.left);
        preorder(node.right);
    }
    return arr;
}
function inorder(node) {
    if (node != null) {
        inorder(node.left);
        arr.push(node.data);
        inorder(node.right);
    }
    return arr;
}