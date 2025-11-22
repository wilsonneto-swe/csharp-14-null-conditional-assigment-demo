# Null Conditional Assignment - C# 14

This new feature help us to write defensive code in a easier way. This feature provides an easy way to avoid null exceptions when assigning values to an object properties.

## Assigning object properties

### C# 13 Approach

```csharp
if (user is not null)
{
    user.Name = "Test";
}
```

### C# 14 - New Approach

```csharp
user?.Name = "Test";
```

## Indexers

### C# 13 Approach

```csharp
if (dict is null)
{
   dict["chave"] = "valor";
}
```

### C# 14 - New Approach

```csharp
dict?["chave"] = "valor";
```
