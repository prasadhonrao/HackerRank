def get_attr_number(node):
    return sum(len(n.attrib) for n in node.iter())