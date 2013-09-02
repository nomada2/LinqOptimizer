﻿namespace LinqOptimizer.Core
    
    open System
    open System.Collections
    open System.Collections.Generic
    open System.Linq
    open System.Linq.Expressions
    open System.Reflection

    // Typed Wrapper for QueryExpr 
    type QueryExpr<'T>(queryExpr : QueryExpr) =
        member self.QueryExpr = queryExpr 
    // Main Query representation
    and QueryExpr = 
        | Source of IEnumerable * Type
        | Transform of LambdaExpression * QueryExpr 
        | Filter of LambdaExpression * QueryExpr 
        | Aggregate of (obj *  Type) * LambdaExpression * QueryExpr
        | Sum of QueryExpr * Type
           
     




            


        
        