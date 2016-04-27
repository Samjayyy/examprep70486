exam 70-486:

-- Objective 1.4: Configure state management

	Examples:
		■ Cache, which is a memory pool stored on the server and shared across users
			- Caution in web farm setting
			- It's also possible to use other technologies for this
			
		■ Session, which is stored on the server and unique for each user
			- Is possible to create your own session provider
			
		■ Cookies, which are stored on the client and passed with each HTTP request to the
		server

		■ QueryString, which is passed as part of the complete URL string

		■ Context.Items, which is part of the HttpContext and lasts only the lifetime of that
		request

		■ Profile, which is stored in a database and maintains information across multiple
		sessions

		
	HTML5 clientside:
		- Localstorage vs Sessionstorage (NOTE: check result open in new tab/window)
		
	Implement sessionless state:
		- E.g. Determine unique identifier at first visit and pass it from request to request
		
-- Objective 1.5: Design a caching strategy

	-- Page output caching
		- Duration: time it will stay in cache
		- VaryByParam: cache per unique value of given param
		- Location: determines who/where to cache. E.g. ServerAndClient does not allow proxies to cache
	-- Donut Caching (not supported by razor engine)
	-- Donut Hole Caching
		- ChildActionOnly: This is serverside cached, useful for heavy computations
	-- Distribution Caching: (No demo)
		- e.g. appfabric. important that you know where and how to use
	
	-- Implement Application caching: (No demo)
		- Cache manifest
		- Only cleared
			■ When the user clears the cache
			■ When there is any change in the manifest fie
			■ When the cache is updated programmatically via JavaScript
	
	-- Implementing HTTP caching (No demo)
		- E.g. use HTTP status codes when nothing has changed
	
	
-- Objective 1.6: Design and implement a WebSocket strategy
	-- Websockets
		- TCP-based, enables two-way communication to occur over a single connection
	
	-- HTTP polling
		- send AJAX requests at regulary scheduled times
	-- HTTP long-polling
		- server-side technique that keeps request open until it has data to return
		- The HTTP request-response model was not designed for it, so handling communication errors is part of the implementation here
	-- Websockets
		- new approach to supporting duplex communication
		
-- Objective 1.7: Design hTTP modules and handlers
	-- Example HTTP module to load external content async
	-- Example HTTP handler (shown in 1.6)
		- unlike with modules only 1 handler is used for 1 request 
	
	
	
	
	
	