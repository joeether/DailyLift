self.addEventListener('install', event => {
    console.log('DailyLift service worker installed.');
    self.skipWaiting();
});

self.addEventListener('activate', event => {
    console.log('DailyLift service worker activated.');
});

self.addEventListener('fetch', event => {
    // Let the browser handle requests normally for now.
});