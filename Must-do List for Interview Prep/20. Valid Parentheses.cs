// 20. Valid Parentheses

public class Solution {
    public bool IsValid(string s) {
        Stack parens = new Stack();
        
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                parens.Push(c);
            } else {
                if (parens.Count == 0) {
                    return false;
                } else {
                    switch((char) parens.Pop()) {
                        case '(':
                            if (c != ')')
                                return false;
                            break;
                        case '[':
                            if (c != ']')
                                return false;
                            break;
                        case '{':
                            if (c != '}')
                                return false;
                            break;
                        default:
                            return false;
                    }
                }
            }
        }

        return parens.Count == 0;
    }
}
