/**
 * Created by Anton Skudarnov on 09.10.2017.
 */
public class Relation extends Expression {
    enum Opcode {less, less_eq, greater, greater_eq, equal, not_equal, none}
    Opcode op;
    Factor left, right;
}
