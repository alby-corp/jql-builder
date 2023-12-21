﻿namespace JQLBuilder.Renders;

using global::JqlBuilder.Types.Abstract;
using global::JqlBuilder.Types.Enum;

internal interface IJqlTypeRender
{
    void Field(string value);

    void String(string value);

    void Bool(bool value);

    void Number(int value);

    void BinaryOperator(IJqlType left, string name, IJqlType right, Priority priority);
    public void UnaryOperator(IJqlType left, string name, Direction direction);

    void Collection(IReadOnlyList<IJqlType> values);
}