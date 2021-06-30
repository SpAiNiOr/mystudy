import http.client

conn = http.client.HTTPSConnection("api-demo.airwallex.com", 443, timeout=10)

payload = "{}"

headers = {
  "Content-Type": "application/json",
  "x-api-key": "",
  "x-client-id": ""
}

conn.request("POST", "/api/v1/authentication/login", payload, headers)

res = conn.getresponse()
data = res.read()

print(data.decode("utf-8"))