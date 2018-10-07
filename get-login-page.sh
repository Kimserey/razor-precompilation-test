curl -o /dev/null \
  -w %{time_total}\\n \
  http://localhost:5500/account/login \
  -H 'Cache-Control: no-cache'