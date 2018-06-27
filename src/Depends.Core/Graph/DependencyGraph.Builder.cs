﻿using System.Collections.Generic;

namespace Depends.Core.Graph
{
    public sealed partial class DependencyGraph
    {
		public sealed class Builder
		{
		    private HashSet<Node> _nodes = new HashSet<Node>();
		    private HashSet<Edge> _edges = new HashSet<Edge>();

		    public Builder WithEdges(IEnumerable<Edge> edges)
		    {
		        foreach (var edge in edges)
		        {
		            _edges.Add(edge);
		        }

		        return this;
		    }

		    public Builder WithEdge(Edge edge)
		    {
		        _edges.Add(edge);
		        return this;
		    }

		    public Builder WithNodes(IEnumerable<Node> nodes)
		    {
		        foreach (var node in nodes)
		        {
		            _nodes.Add(node);
		        }

		        return this;
		    }

		    public Builder WithNode(Node node)
		    {
		        _nodes.Add(node);
		        return this;
		    }

            public DependencyGraph Build()
		    {
				return new DependencyGraph(_nodes, _edges);
		    }
		}
    }
}