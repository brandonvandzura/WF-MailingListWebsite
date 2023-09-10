const PROXY_CONFIG = [
  {
    context: [
      "/mailinglist",
      "/userConfirm",
    ],
    target: "https://localhost:7100",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
