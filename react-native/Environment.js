const ENV = {
  dev: {
    apiUrl: 'http://localhost:44341',
    oAuthConfig: {
      issuer: 'http://localhost:44341',
      clientId: 'AlleClimb_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access AlleClimb',
    },
    localization: {
      defaultResourceName: 'AlleClimb',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44341',
    oAuthConfig: {
      issuer: 'http://localhost:44341',
      clientId: 'AlleClimb_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access AlleClimb',
    },
    localization: {
      defaultResourceName: 'AlleClimb',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
