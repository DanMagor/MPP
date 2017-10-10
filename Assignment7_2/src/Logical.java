/**
 * Created by Anton Skudarnov on 09.10.2017.
 */
public class Logical extends Expression {
    enum Opcode {and, or, xor,none}
    Opcode op;
    Relation left, right;
}
